# AkkaNetClustering

Sample project how clustered actor systems work.

## Lighthouse

The lighthouse project acts as a seed node.
This code is taken from the github pages itself:
[https://github.com/petabridge/lighthouse](https://github.com/petabridge/lighthouse).

Use the lighthouse project in conjunction with either the sample app or the globomantics solution.
The projects are located in its dedicated solution folder.

Next modify the lighthouse HOCON file to match the required setup. There are 3 sections:
- lighthouse
- akka.remote.helios.tpc
- cluster

Each section is marked with comments indicating where to change the configuration.
There is probably a much easier way how to configure this but that is out of scope...

## Purpose

Once the lighthouse project is up and running, you can start multiple instances of the the api app, which is the core of the project, being scaling out.
Only start one instance of the client, it will round robin tasks around all running api nodes.

The SampleActorSystem is less relevant since it only show how to connect to the lighthouse seed node.