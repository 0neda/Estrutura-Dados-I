using System;
using Trees;

Tree<int> tree = new Tree<int>();

tree.Root = new TreeNode<int>() {
    Data = 1000
};

// Troca o valor de data no nó raíz
tree.Root.Data = 100;

tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 5, Parent = tree.Root }
};

// Adicionando nó em tempo de execução
TreeNode<int> filho3 = new TreeNode<int>();
filho3.Data = 35;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);

/* Adicionando netos de root no primeiro filho, ou seja,
filhos do primeiro nível de hereditariedade */
tree.Root.Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root.Children[0] }
};
/* Adicionando netos de root no segundo filho, ou seja,
filhos do primeiro nível de hereditariedade */
TreeNode<int> neto2 = new TreeNode<int>();
neto2.Data = 200;
neto2.Parent = tree.Root.Children[1];
tree.Root.Children[1].Children = new List<TreeNode<int>>();
tree.Root.Children[1].Children.Add(neto2);

int level = neto2.GetHeight();
string message = $"Esta árvore contém {level} níveis";
Console.WriteLine(message);