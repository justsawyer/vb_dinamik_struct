Public Class Form1


    Structure UserBilgi
        Public KullaniciIsmi As String
        Private KullaniciSifresi As String
        Public Adi As String
        Public soyadi As String

        Public Sub set_KullaniciSifresi(ByVal sifre As String)
            KullaniciSifresi = sifre
        End Sub

        Public Function get_KullaniciSifresi() As String
            Return KullaniciSifresi
        End Function

    End Structure
    Structure AdresBilgi
        Private Adresi As String
        Private sehiri As String
        Private ilcesi As String
        Private telefonu As String
        Private GSMsi As String

        Public Sub set_Adres(ByVal address As String)
            Adresi = address
        End Sub
        Public Sub set_sehir(ByVal city As String)
            sehiri = city
        End Sub
        Public Sub set_ilcesi(ByVal district As String)
            ilcesi = district
        End Sub
        Public Sub set_telefon(ByVal telephone As String)
            telefonu = telephone
        End Sub
        Public Sub set_gsm(ByVal mobilePhone As String)
            GSMsi = mobilePhone
        End Sub


        Public Function get_adres() As String
            Return Adresi
        End Function
        Public Function get_sehir() As String
            Return sehiri
        End Function
        Public Function get_ilce() As String
            Return ilcesi
        End Function
        Public Function get_telefon() As String
            Return telefonu
        End Function

        Public Function get_gsm() As String
            Return GSMsi
        End Function
    End Structure
    Structure Kullanici

        Public UserB As UserBilgi
        Public AdresB As AdresBilgi

    End Structure

    Public Sub Temizle()
        txt_adres.Text = ""
        txt_aranacak.Text = ""
        txt_gsm.Text = ""
        txt_ilce.Text = ""
        txt_kSoyadi.Text = ""
        txt_kAdi.Text = ""
        txt_kIsmi.Text = ""
        txt_telefon.Text = ""
        txt_sehir.Text = ""
        txt_sifre.Text = ""

    End Sub











End Class
