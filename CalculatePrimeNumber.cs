using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrimeNumbersCalculatorGP
{
    /// <summary>
    /// Calculate prime numbers, main calculating method CalculateAsync , can be stoped by two ways
    /// by elapsed time defined in timeoutToken or manualy by user manualOperationtoken. Extra stoper 
    /// is monitoring how long calculating task lasts , and stoper is stoped when time finishes 
    /// or by catching exception signaling cancel, and its hold togheter with other values from cycle 
    /// in calculationResult.
    /// </summary>
    public class CalculatePrimeNumber
    {

        CalculationResult _lastCalculationResult = null;
        long _prime = 0;  //==primenumber
        DateTime _whenFound = DateTime.MinValue;
        
        CancellationTokenSource _timeoutToken = null;
        CancellationTokenSource _manualOperationToken = null;
        CancellationTokenSource _linkedTokens = null;

        public CalculatePrimeNumber(CalculationResult lastCalculationResult, int defaultCycleLengthInSeconds)
        {
            if (lastCalculationResult == null)
            {
                _lastCalculationResult = new CalculationResult();
                _lastCalculationResult.CycleNumber = 1;
            }
            else
            {
                _lastCalculationResult = lastCalculationResult;
                _lastCalculationResult.CycleNumber++;
            }

            TimeSpan timeLimit = TimeSpan.FromSeconds(defaultCycleLengthInSeconds);
            _timeoutToken = new CancellationTokenSource(timeLimit);
            _manualOperationToken = new CancellationTokenSource();
            _linkedTokens = CancellationTokenSource.CreateLinkedTokenSource(_timeoutToken.Token, _manualOperationToken.Token);
        }

        public async Task<CalculationResult> CalculateAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Task<CalculationResult> calculationTask = Task.Run(() 
                => CalculatePrime(_linkedTokens.Token,_lastCalculationResult.CycleNumber++), _linkedTokens.Token);
            try
            {
                var result = await calculationTask;
                stopwatch.Stop();
                DateTime duration = DateTime.MinValue + stopwatch.Elapsed;
                result.CycleDuration = duration;
                return result;
            }
            catch (OperationCanceledException)
            {
                stopwatch.Stop();
                var result = calculationTask.Result;
                DateTime duration = DateTime.MinValue + stopwatch.Elapsed;
                result.CycleDuration = duration;
                return result;
            }
            finally
            {
                _linkedTokens.Dispose();
                _manualOperationToken.Dispose();
                _timeoutToken.Dispose();
            }
        }
        CalculationResult CalculatePrime(CancellationToken token,int cycle)
        {
            bool primeWasFound = false;
            long startNumber = _lastCalculationResult.LastPrimeNumber;

            while (!token.IsCancellationRequested)
            {
                if (IsPrime(startNumber))
                {
                    _prime = startNumber;
                    _whenFound = DateTime.Now; 
                    primeWasFound = true;
                }
                    startNumber++;

                if (token.IsCancellationRequested)
                    break;
            }

            CalculationResult result = new CalculationResult();
            result.CycleNumber = cycle;
            result.LastPrimeNumber = _prime;
            result.WhenPrimeNumberWasFound = _whenFound;
            result.PrimeNumberWasCalculated = primeWasFound;
            return result;
        }
        private bool IsPrime(long number)
        {
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void CancelManual()
        {
            if (_manualOperationToken != null)
            {
                _manualOperationToken.Cancel();
            }
        }

    }
}
