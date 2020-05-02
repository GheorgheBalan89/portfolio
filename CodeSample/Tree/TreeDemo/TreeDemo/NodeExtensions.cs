using System;
using System.Collections.Generic;
using System.Linq;
using TreeDemo;

public static class NodeExtensions
{
    public static Node Next(this Node node)
    {
        var nodes = IterateNodes(node).ToList();
     
        while (nodes.Any())
        {
            if (nodes.Count > 1)
            {
                var remainingNodes = nodes.Skip(1).ToList();
                
                if (remainingNodes.Any())
                {
                    var restNodeArray = remainingNodes.Skip(1).Select(remainingNode => new Node(remainingNode)).ToArray();
                    return new Node(remainingNodes.FirstOrDefault(), restNodeArray);
                }
                return null;
            }
            return null;
        }

        return null;
    }

    private static IEnumerable<int> IterateNodes(Node node)
    {
        return ExtractAllChildNodes(node, new Dictionary<int, int>()).Values;
    }

    private static Dictionary<int, int> ExtractAllChildNodes(Node node,  Dictionary<int, int> nodes, int key = 0)
    {
        var tempNodeDictionary = nodes;
        if (!tempNodeDictionary.ContainsKey(key))
        {
           tempNodeDictionary.Add(key++, node.Data);
        }
        else if (tempNodeDictionary.ContainsKey(key) && tempNodeDictionary[key] != node.Data)
        {
            key++;
            tempNodeDictionary.Add(key, node.Data);
        }
        
        foreach (var grandChild in node.Children)
        {
            tempNodeDictionary.Union(ExtractAllChildNodes(grandChild, tempNodeDictionary, tempNodeDictionary.Count()));
        }
      
        return tempNodeDictionary;
    }
}