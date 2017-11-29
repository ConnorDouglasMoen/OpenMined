﻿using System;

namespace OpenMined.Syft.Tensor
{
    public partial class FloatTensor
    {
        private void SameSizeDimensionsAndShape(ref FloatTensor tensor)
        {
            // Check if both tensors have same size
            if (tensor.Size != size)
            {
                throw new InvalidOperationException("Tensors cannot be added since they have different sizes.");
            }
            // Check if both tensors have same number of dimensions
            if (tensor.Shape.Length != shape.Length)
            {
                throw new InvalidOperationException(
                    "Tensors cannot be added since they have different number of dimensions.");
            }
            // Check if both tensors have same shapes
            for (var i = 0; i < shape.Length; i++)
            {
                if (shape[i] != tensor.Shape[i])
                {
                    throw new InvalidOperationException("Tensors cannot be added since they have different shapes.");
                }
            }
        }

        private void SwapElements(ref int[] target, int index1, int index2)
        {
            int tmp = target[index1];
            target[index1] = target[index2];
            target[index2] = tmp;
        }
    }
}