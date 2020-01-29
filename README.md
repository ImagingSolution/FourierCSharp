# FourierCSharp
C# Fourier Transform (FFT, DFT) Sample Program

フーリエ変換をC#で行うサンプルプログラムです。
https://dasan18.com/2018/06/26/post-2586/

フーリエ変換の処理部分はライブラリにしているので、他のプログラムからも使い易い？かと思います。
基本的に Fourierメソッドを呼び出してもらい、データの個数に基づき、FFT か DFT かを内部で使い分けるようにしています。
