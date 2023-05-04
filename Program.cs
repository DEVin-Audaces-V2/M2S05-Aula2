using System.Globalization;
using System.IO;
using Escola.Service;
using Escola.Interface;
using Escola.Mocks;


IPessoasService _pessoasService = new PessoasService();

MenuService _menuService = new MenuService(_pessoasService);

_menuService.ExibirMenu();


