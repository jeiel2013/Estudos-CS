programa
{

     cadeia velha[3][3]

     funcao inicio()
     {
          cadeia posicao = ""
          inicializar()
          impressao()
          escreva("\n")
          escreva("Digite a posição para 'O': ")
          leia(posicao)
          validarJogadaO(posicao, "O")
          validarJogadaX(posicao, "X")
     }

     funcao inicializar()
     {
          para (inteiro L = 0; L < 3; L = L + 1) {
               para (inteiro C = 0; C < 3; C = C + 1) {
                    se (L % 2 == 0) {
                         velha[L][C] = " "
                    }
                    senao {
                         velha[L][C] = " "
                    }
               }
          }
     }

     funcao impressao()
     {
          para (inteiro L = 0; L < 3; L = L + 1) {
               para (inteiro C = 0; C < 3; C = C + 1) {
                    se (C < 2) {
                         escreva(velha[L][C] + " | ")
                    }
                    senao {
                         escreva(velha[L][C])
                    }
               }
               se (L < 2) {
                    escreva("\n")
                    escreva("_________\n")
               }
          }
     }

     funcao validarJogadaO(cadeia pos, cadeia jogador)
     {
          se (pos == "A1") {
               velha[0][0] = jogador
          }
          senao se (pos == "A2") {
               velha[1][0] = jogador
          }
          senao se (pos == "A3") {
               velha[2][0] = jogador
          }
          senao se (pos == "B1") {
               velha[0][1] = jogador
          }
          senao se (pos == "B2") {
               velha[1][1] = jogador
          }
          senao se (pos == "B3") {
               velha[2][1] = jogador
          }
          senao se (pos == "C1") {
               velha[0][2] = jogador
          }
          senao se (pos == "C2") {
               velha[1][2] = jogador
          }
          senao se (pos == "C3") {
               velha[2][2] = jogador
          }
          limpa()
          impressao()
     }

	funcao validarJogadaX(cadeia posi, cadeia jogadorX)
     {
          se (posi == "A1") {
               velha[0][0] = jogadorX
          }
          senao se (posi == "A2") {
               velha[1][0] = jogadorX
          }
          senao se (posi == "A3") {
               velha[2][0] = jogadorX
          }
          senao se (posi == "B1") {
               velha[0][1] = jogadorX
          }
          senao se (posi == "B2") {
               velha[1][1] = jogadorX
          }
          senao se (posi == "B3") {
               velha[2][1] = jogadorX
          }
          senao se (posi == "C1") {
               velha[0][2] = jogadorX
          }
          senao se (posi == "C2") {
               velha[1][2] = jogadorX
          }
          senao se (posi == "C3") {
               velha[2][2] = jogadorX
          }
          limpa()
          impressao()
     }

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 2111; 
 * @DOBRAMENTO-CODIGO = [17, 31, 49, 82];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */