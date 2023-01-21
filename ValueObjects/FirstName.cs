using ValuObjectsWebApi.Primitives;

namespace ValuObjectsWebApi.ValueObjects
{
    public sealed class FirstName : ValueObject
    {
        public string Value { get; }
        private FirstName(string value)
        {
            Value = value;
        }

        public static FirstName Create(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new Exception("Ad alanı boş geçilemez!");

            if (firstName.Length > 50) throw new Exception("Ad alanı en fazla 50 karakter olabilir");

            return new FirstName(firstName);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
