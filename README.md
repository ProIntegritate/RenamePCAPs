# RenamePCAPs
Code to remove the sequence number from PCAP files captured in a ringbuffer.

Basically you just run it in the folder you're in and it does it stuff.

Example: Files with the name like:
* _stuff_00001_20210409092141.pcap
* _stuff_00002_20210409093141.pcap
* _stuff_00003_20210409094142.pcap
* (...)

Will end up looking like:
* _stuff_20210409092141.pcap
* _stuff_20210409093141.pcap
* _stuff_20210409094142.pcap
* (...)

So, it will saving the basename + timestamp of the filename so you can intermix multiple sets of pcaps with the base name.
