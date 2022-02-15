using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertoDecimal(firstNumber) + ConvertoDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = ConvertoDecimal(firstNumber) / ConvertoDecimal(secondNumber);

                return Ok(div.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("Mul/{firstNumber}/{secondNumber}")]
        public IActionResult Mul(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var Mul = ConvertoDecimal(firstNumber) * ConvertoDecimal(secondNumber);

                return Ok(Mul.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("Pow/{firstNumber}/{secondNumber}")]
        public IActionResult Pow(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var Pow = Math.Pow(ConvertoDecimal(firstNumber), ConvertoDecimal(secondNumber));

                return Ok(Pow.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private double ConvertoDecimal(string Number)
        {
            double result = 0;
            double.TryParse(Number, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out result);
            return result;
        }

        private bool IsNumeric(string Number)
        {
            double number;
            bool isNumber = double.TryParse(Number, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber; 

        }
    }
}