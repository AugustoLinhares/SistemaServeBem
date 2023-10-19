//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using SisServeBem.Classes;
//using FluentValidation;

//namespace SisServeBem.Classes
//{   
//        class ClienteValitador : AbstractValidator<Cliente>
//        {
//            public ClienteValitador()
//            {
//                RuleFor(x => x.Nome).NotEmpty().WithMessage("O campo `Nome` é Obrigatório. Favor Preencher");
//                RuleFor(x => x.Numero).NotEqual("(__)_____-____").WithMessage("O campo `Telefone` é obrigatório. Favor Preencher");
//                RuleFor(x => x.Email).NotEmpty();
//                RuleFor(x => x.Endereco).NotEmpty();
//                RuleFor(x => x.Cidade).NotEmpty();
//                RuleFor(x => x.CPF).Must(CPFValidator).WithMessage("CPF inválido");
//        }

//        public bool CPFValidator(string cpf)
//            {
//            return true;
//            }
//        }  
//}

