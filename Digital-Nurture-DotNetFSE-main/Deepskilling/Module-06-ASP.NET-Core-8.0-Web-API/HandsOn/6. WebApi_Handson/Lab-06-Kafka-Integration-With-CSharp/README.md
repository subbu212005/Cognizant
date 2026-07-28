# Lab 6: Kafka Integration with C#

## Objective

This hands-on demonstrates how to integrate Apache Kafka with a C# application for real-time message streaming. The lab covers Kafka installation, topic creation, message publishing, and message consumption using a simple chat application.

---

# Learning Objectives

- Understand Apache Kafka.
- Learn Kafka Architecture.
- Understand Topics, Partitions, and Brokers.
- Install and configure Kafka.
- Understand ZooKeeper.
- Create Kafka Producer.
- Create Kafka Consumer.
- Build a simple Chat Application using C#.
- Consume messages in multiple clients.

---

# Software Requirements

- Visual Studio 2022
- .NET 8 SDK
- Apache Kafka
- ZooKeeper
- Confluent.Kafka NuGet Package

---

# Kafka Architecture

Producer

↓

Kafka Broker

↓

Topic

↓

Consumer

---

# Kafka Components

## Producer

Publishes messages.

## Consumer

Reads messages.

## Topic

Stores messages.

## Broker

Kafka Server.

## ZooKeeper

Coordinates Kafka Brokers.

---

# Hands-on Tasks

### Start ZooKeeper

```

zookeeper-server-start.bat ../../config/zookeeper.properties

```

---

### Start Kafka Server

```

kafka-server-start.bat ../../config/server.properties

```

---

### Create Topic

```

kafka-topics.bat --create --topic chat-message --bootstrap-server localhost:9092 --partitions 1 --replication-factor 1

```

---

### Start Producer

```

kafka-console-producer.bat --broker-list localhost:9092 --topic chat-message

```

---

### Start Consumer

```

kafka-console-consumer.bat --bootstrap-server localhost:9092 --topic chat-message --from-beginning

```

---

# Demo

- Kafka Server Running
- ZooKeeper Running
- Topic Created
- Producer Sending Messages
- Consumer Receiving Messages
- Windows Forms Chat Application

---

# Conclusion

Successfully implemented a Kafka-based chat application using C# with real-time message streaming.