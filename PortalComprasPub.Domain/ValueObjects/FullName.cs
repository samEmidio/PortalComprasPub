// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using System;
using System.Collections.Generic;
using System.Linq;
namespace PortalComprasPub.Domain.ValueObjects
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static FullName Create(string firstName, string lastName)
        {
            return new FullName(firstName, lastName);
        }

        private FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
