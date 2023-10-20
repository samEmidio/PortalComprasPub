// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


namespace PortalComprasPub.Domain.ValueObjects
{
    public struct FullName
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static FullName Create(string firstName, string lastName)
        {
            return new FullName(firstName, lastName);
        }

        

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }

        private FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
