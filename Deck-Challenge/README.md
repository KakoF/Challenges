Advent Of Code 2020

Leva apenas algumas horas de navegação no oceano em uma jangada para o tédio se instalar. Felizmente, você trouxe um pequeno baralho de cartas espaciais! Você gostaria de jogar uma partida de Combate, e há até mesmo um oponente disponível: um pequeno caranguejo que subiu a bordo da sua jangada antes de você partir.

Felizmente, não demora muito para ensinar as regras ao caranguejo.

Antes de começar o jogo, divida as cartas para que cada jogador tenha seu próprio baralho (seu input). Em seguida, o jogo consiste em uma série de rodadas: ambos os jogadores compram a carta do topo de seus baralhos, e o jogador com a carta de maior valor vence a rodada. O vencedor fica com ambas as cartas, colocando-as na parte inferior de seu próprio baralho para que a carta do vencedor fique acima da outra carta. Se isso fizer com que um jogador tenha todas as cartas, ele vence, e o jogo termina.

Por exemplo, considere os seguintes baralhos iniciais:

Jogador 1:
9
2
6
3
1

Jogador 2:
5
8
4
7
10
Essa disposição significa que o baralho do jogador 1 contém 5 cartas, com 9 na parte superior e 1 na parte inferior; o baralho do jogador 2 também contém 5 cartas, com 5 na parte superior e 10 na parte inferior.

A primeira rodada começa com ambos os jogadores comprando a carta do topo de seus baralhos: 9 e 5. O jogador 1 tem a carta mais alta, então ambas as cartas se movem para a parte inferior do baralho do jogador 1, de modo que 9 fique acima de 5. No total, são necessárias 29 rodadas antes que um jogador tenha todas as cartas:

-- Round 1 --
Player 1's deck: 9, 2, 6, 3, 1
Player 2's deck: 5, 8, 4, 7, 10
Player 1 plays: 9
Player 2 plays: 5
Player 1 wins the round!

-- Round 2 --
Player 1's deck: 2, 6, 3, 1, 9, 5
Player 2's deck: 8, 4, 7, 10
Player 1 plays: 2
Player 2 plays: 8
Player 2 wins the round!

-- Round 3 --
Player 1's deck: 6, 3, 1, 9, 5
Player 2's deck: 4, 7, 10, 8, 2
Player 1 plays: 6
Player 2 plays: 4
Player 1 wins the round!

-- Round 4 --
Player 1's deck: 3, 1, 9, 5, 6, 4
Player 2's deck: 7, 10, 8, 2
Player 1 plays: 3
Player 2 plays: 7
Player 2 wins the round!

-- Round 5 --
Player 1's deck: 1, 9, 5, 6, 4
Player 2's deck: 10, 8, 2, 7, 3
Player 1 plays: 1
Player 2 plays: 10
Player 2 wins the round!

...several more rounds pass...

-- Round 27 --
Player 1's deck: 5, 4, 1
Player 2's deck: 8, 9, 7, 3, 2, 10, 6
Player 1 plays: 5
Player 2 plays: 8
Player 2 wins the round!

-- Round 28 --
Player 1's deck: 4, 1
Player 2's deck: 9, 7, 3, 2, 10, 6, 8, 5
Player 1 plays: 4
Player 2 plays: 9
Player 2 wins the round!

-- Round 29 --
Player 1's deck: 1
Player 2's deck: 7, 3, 2, 10, 6, 8, 5, 9, 4
Player 1 plays: 1
Player 2 plays: 7
Player 2 wins the round!


== Post-game results ==
Player 1's deck: 
Player 2's deck: 3, 2, 10, 6, 8, 5, 9, 4, 7, 1
Quando o jogo termina, você pode calcular a pontuação do jogador vencedor. A carta inferior em seu baralho vale o valor da carta multiplicado por 1, a segunda carta de baixo para cima vale o valor da carta multiplicado por 2, e assim por diante. Com 10 cartas, a carta superior vale o valor da carta multiplicado por 10. Neste exemplo, a pontuação do jogador vencedor é:

   3 * 10
+  2 *  9
+ 10 *  8
+  6 *  7
+  8 *  6
+  5 *  5
+  9 *  4
+  4 *  3
+  7 *  2
+  1 *  1
= 306
Portanto, uma vez que o jogo termina, a pontuação do jogador vencedor é 306.

Jogue contra o pequeno caranguejo em uma partida de Combate usando os dois baralhos que você acabou de distribuir. Qual é a pontuação do jogador vencedor?