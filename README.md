# FourierCSharp
C# Fourier Transform (FFT, DFT) Sample Program

フーリエ変換をC#で行うサンプルプログラムです。
![2020-01-26_22h18_33](https://user-images.githubusercontent.com/29155364/73358968-1aa12800-42e3-11ea-8593-6f51882e0779.png)

フーリエ変換の処理部分はライブラリにしているので、他のプログラムからも使い易い？かと思います。
基本的に Fourierメソッドを呼び出してもらい、データの個数に基づき、FFT か DFT かを内部で使い分けるようにしています。
