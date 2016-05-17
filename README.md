# AkkaNetClustering

Sample project how clustered actor systems work.

## Lighthouse

The lighthouse project acts as a seed node.
This code is taken from the github pages itself:
[https://github.com/petabridge/lighthouse](https://github.com/petabridge/lighthouse).

Use the lighthouse project in conjunction with either the sample app or the globomantics solution. Each project is located in its dedicated solution folder.
Set each project as startup project accordingly.

Next modify the lighthouse HOCON file to match the required setup. There are 3 sections:
- lighthouse
- akka.remote.helios.tpc
- cluster

Each section is marked with comments indicating where to change the configuration.