<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mapa.aspx.cs" Inherits="SiteWeb.Mapa" %>


<!DOCTYPE html>
<html>
  <head>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
        <style type="text/css">
      html { height: 100% }
      body { height: 100%; margin: 0; padding: 0 }
      #map { height: 100% }
    </style>
         https://developers.google.com/maps/documentation/javascript/tutorial -->
    <link rel="stylesheet" href="/maps/documentation/javascript/demos/demos.css">
   
  </head>
  <body>
       <div id="map"></div>
    <script type="text/javascript">
        function getParameterByName(name) {
            name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
            var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
                results = regex.exec(location.search);
            return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
        }
        var LatVis = new Number(getParameterByName('Latitud'));
        var LonVis = new Number(getParameterByName('Longitud'));
        navigator.geolocation.getCurrentPosition(initMap)



        function initMap(rta) {
            var lat = rta.coords.latitude;
            var lon = rta.coords.longitude;
            var gLatLon = new google.maps.LatLng(lat, lon);
            //var LatVis = getParameterByName('Latitud');
            //var LonVis = getParameterByName('Longitud');
            //var LatVis = getQueryVariable('Latitud');
            //var LonVis = getQueryVariable('Longitud');
            //var chicago = { lat: 41.85, lng: -87.65 };

            var Vistony = new google.maps.LatLng(LatVis,LonVis);
            //var Vistony = { lat: LatVis, lng: LonVis };

            var map = new google.maps.Map(document.getElementById('map'), {
                center: gLatLon,
                zoom: 7
            });

            var directionsDisplay = new google.maps.DirectionsRenderer({
                map: map
            });

            // Set destination, origin and travel mode.
            var request = {
                destination: gLatLon,
                origin: Vistony,
                travelMode: 'DRIVING'
            };

            // Pass the directions request to the directions service.
            var directionsService = new google.maps.DirectionsService();
            directionsService.route(request, function (response, status) {
                if (status == 'OK') {
                    // Display the route on the map.
                    directionsDisplay.setDirections(response);
                }
            });
            var trafficLayer = new google.maps.TrafficLayer();
            trafficLayer.setMap(map)


        }
        

        //function getQueryVariable(variable) {
        //    var query = window.location.search.substring(1);
        //    var vars = query.split("&");
        //    for (var i = 0; i < vars.length; i++) {
        //        var pair = vars[i].split("=");
        //        if (pair[0] == variable) {
        //            return pair[1];
        //        }
        //    }
        //    return false;
        //}

    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDAqwKC06eCZpcEasgP8DrRKU9kiUhR88s&callback=initMap"
        async defer></script>
</body>

</html>
