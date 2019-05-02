using System;

public class Class1
{
	public Class1()
	{
        Bitmap grayscale = (Bitmap)GrayscaleUtils.ColorToGrayscale(inputImagePictureBox.Image);

        grayscaleImagePictureBox.Image = grayscale;

        int[,] array2D = ImageDataConverter.BitmapToArray2D(grayscale);

        Bitmap grayScaleAgain = ImageDataConverter.Array2DToBitmap(array2D);

        processedImagePictureBox.Image = grayScaleAgain;
    }
}
