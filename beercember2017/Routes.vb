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

        beers.Add(New BeerDay("Empire", "Particle City", "8.0", "50", "https://untappd.com/b/empire-brewing-company-particle-city/1932806"))
        beers.Add(New BeerDay("Mill House", "Köld One", "4.6", "19", "https://untappd.com/b/mill-house-brewing-company-kold-one/497750"))
        beers.Add(New BeerDay("Big Ditch", "Make Me Wanna Stout", "5.2", "31", "https://untappd.com/b/big-ditch-brewing-company-make-me-wanna-stout/1780815"))
        beers.Add(New BeerDay("M.I.A.", "Mega Mix", "6.0", "50", "https://untappd.com/b/m-i-a-beer-co-megamix/1101348"))
        beers.Add(New BeerDay("Abbaye de Leffe", "Blonde", "6.6", "20", "https://untappd.com/b/abbaye-de-leffe-leffe-blonde-blond/5940"))
        beers.Add(New BeerDay("Southern Tier", "Crème Brûlée", "10.0", "55", "https://untappd.com/b/southern-tier-brewing-company-creme-brulee/4887"))
        beers.Add(New BeerDay("Common Roots", "Coffee Cup", "9.0", "27", "https://untappd.com/b/common-roots-brewing-company-coffee-cup/1066459"))
        beers.Add(New BeerDay("Faith American", "Ale", "5.0", "--", "https://untappd.com/b/faith-american-brewing-faith-american-ale/2777812"))
        beers.Add(New BeerDay("Cigar City", "Florida Cracker", "5.5", "18", "https://untappd.com/b/cigar-city-brewing-florida-cracker/51262"))
        beers.Add(New BeerDay("Miller", "Mickey's", "5.6", "--", "https://untappd.com/b/miller-brewing-company-mickey-s/7378"))
        beers.Add(New BeerDay("Anderson Valley", "Cherry Gose", "4.2", "--", "https://untappd.com/b/anderson-valley-brewing-company-cherry-gose/2871974"))
        beers.Add(New BeerDay("Westbrook", "White Thai", "5.0", "16", "https://untappd.com/b/westbrook-brewing-co-white-thai/15894"))
        beers.Add(New BeerDay("Bell's", "Kalamazoo Stout", "6.0", "--", "https://untappd.com/b/bell-s-brewery-kalamazoo-stout/4134"))
        beers.Add(New BeerDay("Ommegang", "Pale Sour Ale", "6.9", "9", "https://untappd.com/b/brewery-ommegang-pale-sour-ale/1988565"))
        beers.Add(New BeerDay("Lazy Magnolia", "Southern Hops'pitality", "5.5", "60", "https://untappd.com/b/lazy-magnolia-brewing-company-southern-hops-pitality-ipa/144153"))
        beers.Add(New BeerDay("Two Roads", "Espressway", "6.5", "--", "https://untappd.com/b/two-roads-brewing-company-espressway/1413557"))
        beers.Add(New BeerDay("Narragansett", "Fresh Catch", "4.2", "23", "https://untappd.com/b/narragansett-brewing-company-fresh-catch/2542753"))
        beers.Add(New BeerDay("SingleCut", "18-Watt", "5.0", "80", "https://untappd.com/b/singlecut-beersmiths-18-watt-ipa/83161"))
        beers.Add(New BeerDay("Industrial Arts", "Tools of the Trade", "4.9", "--", "https://untappd.com/b/industrial-arts-brewing-tools-of-the-trade/1658281"))
        beers.Add(New BeerDay("Platform", "Outskirts of Paradise", "7.0", "49", "https://untappd.com/b/platform-beer-company-outskirts-of-paradise/2763393"))
        beers.Add(New BeerDay("Prairie", "Phantasmagoria", "8.0", "70", "https://untappd.com/b/prairie-artisan-ales-phantasmagoria/859804"))
        beers.Add(New BeerDay("Anheuser-Busch", "Copper Lager", "6.2", "--", "https://untappd.com/b/anheuser-busch-budweiser-reserve-copper-lager/2731432"))
        beers.Add(New BeerDay("Highway Manor", "Hong Kong Sayjohn", "6.7", "15", "https://untappd.com/b/highway-manor-brewing-co-hong-kong-sayjohn/1978886"))
        beers.Add(New BeerDay("Prairie", "Christmas Bomb", "13.0", "65", "https://untappd.com/b/prairie-artisan-ales-christmas-bomb/868841"))

        Dim firstDay As Date = #12/2/2018#
        For Each beer As BeerDay In beers
            beer.CalendarDate = firstDay.AddDays(beers.IndexOf(beer))
        Next

        Dim beersToDate As IEnumerable(Of BeerDay) = beers.Where(Function(b) b.CalendarDate <= Date.Now.AddHours(-5).Date)
        Dim sortedBeers As IEnumerable(Of BeerDay) = beersToDate.OrderByDescending(Function(b) b.CalendarDate)

        Return sortedBeers.ToList

    End Function

End Class
