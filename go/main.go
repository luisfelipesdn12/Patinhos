package main

import (
	"fmt"
)

func main() {
	var n int
	fmt.Printf("Digite quantos patinhos foram passear: ")
	fmt.Scanf("%d", &n)

	for i := 1; i <= n; i++ {
		fmt.Printf("\n%d patinhos foram passear\n", i)
		fmt.Println("Além das montanhas")
		fmt.Println("Para brincar")
		fmt.Println("A mamãe gritou: Quá, quá, quá, quá")
		fmt.Printf("mas só %d patinhos voltaram de lá.\n\n", i-1)
	}

	fmt.Println("A mamãe patinha foi procurar")
	fmt.Println("Além das montanhas")
	fmt.Println("Na beira do mar")
	fmt.Println("A mamãe gritou: Quá, quá, quá, quá")
	fmt.Printf("E os %d patinhos voltaram de lá.\n", n)
}
