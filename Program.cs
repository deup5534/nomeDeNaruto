
Console.WriteLine("Digite seu nomezinho: ");
string nomeDigitado = Console.ReadLine()!;
string nomeNinja = nomeDigitado

.Replace("a", "KA")
.Replace("á", "KA")
.Replace("â", "KA")
.Replace("ã", "KA")
.Replace("b", "ZU")
.Replace("c", "MI")
.Replace("d", "TE")
.Replace("e", "KU")
.Replace("é", "KU")
.Replace("ê", "KU")
.Replace("f", "LU")
.Replace("g", "JI")
.Replace("h", "RI")
.Replace("i", "KI")
.Replace("í", "KI")
.Replace("j", "ZUS")
.Replace("k", "ME")
.Replace("l", "TA")
.Replace("m", "RIN")
.Replace("n", "TO")
.Replace("o", "MO")
.Replace("ó", "MO")
.Replace("ô", "MO")
.Replace("õ", "MO")
.Replace("p", "NO")
.Replace("q", "KE")
.Replace("r", "SHI")
.Replace("s", "ARI")
.Replace("t", "CHI")
.Replace("u", "DO")
.Replace("ú", "DO")
.Replace("û", "DO")
.Replace("v", "RU")
.Replace("w", "MEI")
.Replace("x", "NA")
.Replace("y", "FU")
.Replace("z", "ZI")
.ToLower();

nomeNinja = $"{nomeNinja.Substring(0, 1).ToUpper()}{nomeNinja.Substring(1).ToLower()}";

Console.WriteLine($"Seu nome de naruto é: {nomeNinja}!");