using System.Diagnostics.CodeAnalysis;

string nomeHeroi;
int xpHeroi;

Console.WriteLine("Qual o nome do seu herói? ");
nomeHeroi = Convert.ToString(Console.ReadLine());
Console.WriteLine("Qual o XP do seu herói? ");
xpHeroi = Convert.ToInt32(Console.ReadLine());

if (xpHeroi <= 1000){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: FERRO");
}    
 

if (xpHeroi >= 1001 && xpHeroi < 2001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: BRONZE");
}
else if(xpHeroi >= 2001 && xpHeroi < 5001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: PRATA");
}
else if (xpHeroi >= 6001 && xpHeroi < 7001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: OURO");
}
else if (xpHeroi >= 7001 && xpHeroi < 8001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: Platina");
}
else if (xpHeroi >= 8001 && xpHeroi < 9001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: Ascendente");
}
else if (xpHeroi >= 9001 && xpHeroi < 10001){
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: Imortal");
}
else{
    Console.WriteLine($"O nível do herói {nomeHeroi} é equivalente ao rank: Radiante");
};