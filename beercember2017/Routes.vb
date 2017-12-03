Imports Nancy

Public Class Routes : Inherits NancyModule

    Public Sub New()
        [Get]("/hello") = Function() "Hello"
        [Get]("/") = AddressOf GetMain
    End Sub

    Private Function GetMain() As Responses.Negotiation.Negotiator
        Dim model As New BeerData
        model.Beers = GetBeers()
        Return View("main.html", model)
    End Function

    Private Function GetBeers() As List(Of BeerDay)

        Dim beers As New List(Of BeerDay)

        beers.Add(New BeerDay(#12/2/2017#, "Singlecut - Charlie's Good Tonight", "6", "https://untappd.com/b/singlecut-beersmiths-charlie-s-good-tonight/2145656"))
        beers.Add(New BeerDay(#12/3/2017#, "Tröegs - Troegenator", "8.2", "https://untappd.com/b/troegs-independent-brewing-troegenator-doublebock/31961"))
        beers.Add(New BeerDay(#12/4/2017#, "Bitburger - Premium Pils  ", "4.8", "https://untappd.com/b/bitburger-braugruppe-bitburger-premium-pils-premium-beer/17252"))
        beers.Add(New BeerDay(#12/5/2017#, "Brasserie Dieu du Ciel! - Saison Du Parc", "4.2", " link "))
        beers.Add(New BeerDay(#12/6/2017#, "Void of light", "7.9", " link "))
        beers.Add(New BeerDay(#12/7/2017#, "Cream ale", "", " link "))
        beers.Add(New BeerDay(#12/8/2017#, "??", "", " link "))
        beers.Add(New BeerDay(#12/9/2017#, "Alagash Trip ", "9", " link "))
        beers.Add(New BeerDay(#12/10/2017#, "Mickey", "", " link "))
        beers.Add(New BeerDay(#12/11/2017#, "Silly sour", "5.5", " link "))
        beers.Add(New BeerDay(#12/12/2017#, "Blanche de chambly ", "5", " link "))
        beers.Add(New BeerDay(#12/13/2017#, "Yeti", "9.5", " link "))
        beers.Add(New BeerDay(#12/14/2017#, "Liquid truth", "6.8", " link "))
        beers.Add(New BeerDay(#12/15/2017#, "Backwoods bastard ", "11.21", " link "))
        beers.Add(New BeerDay(#12/16/2017#, "Anderson winter", "6.9", " link "))
        beers.Add(New BeerDay(#12/17/2017#, "Pinner", "4.9", " link "))
        beers.Add(New BeerDay(#12/18/2017#, "Nu skool ", "6", " link "))
        beers.Add(New BeerDay(#12/19/2017#, "??", "", " link "))
        beers.Add(New BeerDay(#12/20/2017#, "Brown suga ", "10", " link "))
        beers.Add(New BeerDay(#12/21/2017#, "Stone Xocoveza", "8.1", " link "))
        beers.Add(New BeerDay(#12/22/2017#, "Mikkeller zest ", "7", " link "))
        beers.Add(New BeerDay(#12/23/2017#, "Rochefort", "9.2", " link "))
        beers.Add(New BeerDay(#12/24/2017#, "Bells Christmas ", "7.5", " link "))
        beers.Add(New BeerDay(#12/25/2017#, "Ommegang ", "8.2", " link "))

        Dim beersToDate As IEnumerable(Of BeerDay) = beers.Where(Function(b) b.CalendarDate < Date.Now.Date)

        Return beersToDate.ToList

    End Function

End Class
