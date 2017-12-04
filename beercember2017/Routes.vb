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

        beers.Add(New BeerDay(#12/2/2017#, "Singlecut", "Charlie's Good Tonight", "6.0", "https://untappd.com/b/singlecut-beersmiths-charlie-s-good-tonight/2145656"))
        beers.Add(New BeerDay(#12/3/2017#, "Tröegs", "Troegenator", "8.2", "https://untappd.com/b/troegs-independent-brewing-troegenator-doublebock/31961"))
        beers.Add(New BeerDay(#12/4/2017#, "Bitburger", "Premium Pils  ", "4.8", "https://untappd.com/b/bitburger-braugruppe-bitburger-premium-pils-premium-beer/17252"))
        beers.Add(New BeerDay(#12/5/2017#, "Brasserie Dieu du Ciel!", "Saison Du Parc", "4.2", "https://untappd.com/b/brasserie-dieu-du-ciel-saison-du-parc/1461724"))
        beers.Add(New BeerDay(#12/6/2017#, "Gun Hill Brewing Company", "Void of Light", "7.9", "https://untappd.com/b/gun-hill-brewing-company-void-of-light/712522"))
        beers.Add(New BeerDay(#12/7/2017#, "Genesee Brewing Company", "Cream Ale", "5.2", "https://untappd.com/b/genesee-brewing-company-genesee-cream-ale/2773"))
        beers.Add(New BeerDay(#12/8/2017#, "??", "??", "??", ""))
        beers.Add(New BeerDay(#12/9/2017#, "Allagash Brewing Company", "Tripel", "9.0", "https://untappd.com/b/allagash-brewing-company-tripel/1424"))
        beers.Add(New BeerDay(#12/10/2017#, "Miller Brewing Company", "Mickey's", "5.8", "https://untappd.com/b/miller-brewing-company-mickey-s/7378"))
        beers.Add(New BeerDay(#12/11/2017#, "Brasserie de Silly", "Silly Sour", "5.5", "https://untappd.com/b/brasserie-de-silly-silly-sour/394451"))
        beers.Add(New BeerDay(#12/12/2017#, "Unibroue", "Blanche de Chambly ", "5.0", "https://untappd.com/b/unibroue-blanche-de-chambly/4453"))
        beers.Add(New BeerDay(#12/13/2017#, "Great Divide Brewing Company", "Yeti", "9.5", "https://untappd.com/b/great-divide-brewing-company-yeti/833"))
        beers.Add(New BeerDay(#12/14/2017#, "Dogfish Head", "Liquid Truth Serum", "6.8", "https://untappd.com/b/dogfish-head-craft-brewery-liquid-truth-serum/2008972"))
        beers.Add(New BeerDay(#12/15/2017#, "Founders", "Backwoods Bastard", "11.21", "https://untappd.com/b/founders-brewing-co-backwoods-bastard/6830"))
        beers.Add(New BeerDay(#12/16/2017#, "Anderson Valley", "Winter Solstice", "6.9", "https://untappd.com/b/anderson-valley-brewing-company-winter-solstice/14814"))
        beers.Add(New BeerDay(#12/17/2017#, "Oskar Blues", "Pinner Throwback IPA", "4.9", "https://untappd.com/b/oskar-blues-brewery-pinner-throwback-ipa/912790"))
        beers.Add(New BeerDay(#12/18/2017#, "Southern Tier", "Nu Skool IPA", "6.0", "https://untappd.com/b/southern-tier-brewing-company-nu-skool-ipa/1461111"))
        beers.Add(New BeerDay(#12/19/2017#, "??", "??", "??", ""))
        beers.Add(New BeerDay(#12/20/2017#, "Lagunitas Brewing Company", "Brown Shugga'", "10.0", "https://untappd.com/b/lagunitas-brewing-company-brown-shugga/4740"))
        beers.Add(New BeerDay(#12/21/2017#, "Stone Brewing", "Xocoveza", "8.1", "https://untappd.com/b/stone-brewing-stone-xocoveza/1311232"))
        beers.Add(New BeerDay(#12/22/2017#, "Mikkeller", "Zest Please! ", "7.0", "https://untappd.com/b/mikkeller-zest-please/479449"))
        beers.Add(New BeerDay(#12/23/2017#, "Abbaye Notre-Dame de Saint-Rémy", "Trappistes Rochefort 8", "9.2", "https://untappd.com/b/abbaye-notre-dame-de-saint-remy-trappistes-rochefort-8/11473"))
        beers.Add(New BeerDay(#12/24/2017#, "Bell's", "Christmas Ale", "7.5", "https://untappd.com/b/bell-s-brewery-christmas-ale-2017/2321671"))
        beers.Add(New BeerDay(#12/25/2017#, "Ommegang", "Abbey Ale", "8.2", "https://untappd.com/b/brewery-ommegang-abbey-ale/6510"))

        Dim beersToDate As IEnumerable(Of BeerDay) = beers.Where(Function(b) b.CalendarDate <= Date.Now.Date.AddHours(-5))

        Return beersToDate.ToList

    End Function

End Class
