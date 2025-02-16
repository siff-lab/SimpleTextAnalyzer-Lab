Imports System.IO

Module Program
    Sub Main()
        Console.WriteLine("== Program Analisis File ==")
    
    ' Request path file
    Console.Write("Masukkan path file: ")
    Dim filePath As String = Console.ReadLine()

    ' Cek apakah file ada?
    If File.Exists(filePath) Then
        Console.WriteLine(vbCrLf & "== Hasil Analisis File ==")
        AnalisisFile(filePath)
    Else
        Console.WriteLine("File tidak ditemukan! Pastikan path sudah benar.")
    End If

    Console.WriteLine(vbCrLf & "Tekan ENTER untuk keluar...")
    Console.ReadLine()
End Sub

'Logic untuk analisis File
Sub AnalisisFile(ByVal path As String)
    Try
        Dim fileContent As String = File.ReadAllText(path)

        Dim jumlahKarakter As Integer = fileContent.Replace(vbCr, "").Length

        Dim lines() As String = File.ReadAllLines(path)
        Dim jumlahBaris As Integer = lines.Length

        Dim jumlahKata As Integer = fileContent.Split({" "c, vbTab, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries).Length

        'Output Analisis File
        Console.WriteLine(vbCrLf & " *! RINGKASAN DOKUMEN* ")
        Console.WriteLine("Setelah dianalisis, dokumen ini memiliki sekitar " & jumlahKata & " kata yang tersebar dalam " & jumlahBaris & " baris teks. " &
                        "Dengan total " & jumlahKarakter & " karakter. ")
        
        'Output (Poin-Poin Analisis)
        Console.WriteLine(vbCrLf & " *DETAIL ANALISIS* ")
        Console.WriteLine("-    Jumlah Baris    : " & jumlahBaris)
        Console.WriteLine("-    Jumlah Kata     : " & jumlahKata)
        Console.WriteLine("-    Jumlah Karakter : " & jumlahKarakter)

    Catch ex As Exception
        Console.WriteLine("Mohon Maaf! terjadi kesalahan saat menganalisis file: " & ex.Message)
    End Try
End Sub
End Module