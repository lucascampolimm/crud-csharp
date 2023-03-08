Instruções

1 - Você precisará da IDE do Visual Studio para rodar esse programa.
Você pode obte-lá através do link: https://visualstudio.microsoft.com/pt-br/downloads/

2 - Ao abrir o instador da IDE, você precisará instalar o Desenvolvimento para desktop com .NET.

3 - É recomendável que você tenha o .NET SDK instalado na sua máquina.
Você pode obtê-lo através do link: https://dotnet.microsoft.com/en-us/download

4 - É recomendável que você tenha o pacote de desenvolvedor do .NET Framework instalado na sua máquina.
Você pode obtê-lo através do link: https://dotnet.microsoft.com/pt-br/download/dotnet-framework

5 -
- Especifique o caminho do DB no arquivo JanelaPrinciapal.cs na linha 17.
- É para funcionar apenas especificando no arquivo JanelaPrincipal.cs, mas caso apresente problema especifique também no arquivo ContextoBanco.cs na linha 15.

6 - Você pode abrir o projeto clicando com duplo clique em crud_c_sharp_sqlite.sln

7 - Você pode rodar o projeto apertando F5.

PS:
Caso o Visual Studio não puxe automaticamente as bibliotecas que utilizei, você pode instalá-las manualmente através do gerenciador do NuGet.
As bibliotecas são:

- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Tools
- System.Data.SQLite

PS-2:
Caso o programa apresente o erro "Não é possível converter implicitamente tipo string em System.Windows.Forms", é porque ele não está puxando o Name.Name
Você pode corrigir isso facilmente alterando o atributo Name para Name.Name e salvando o projeto com CTRL + S.

PS-3:
O projeto está um pouco confuso porque de início gerei um DB automaticamente baseado na minha classe Estudante.