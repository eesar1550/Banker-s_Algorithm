# Deadlock Detection and Avoidance System using Banker’s Algorithm

This project implements a Deadlock Detection and Avoidance System using the Banker's Algorithm. It simulates resource allocation in a multi-process system and ensures system safety by avoiding deadlocks.

## 🔍 Overview

The Banker's Algorithm is a resource allocation and deadlock avoidance algorithm that tests for safety by simulating the allocation for a predetermined maximum possible amount of all resources, then makes an "s-state" check to test for possible activities before deciding whether allocation should be allowed to continue.

## 💡 Features

- Safe state detection
- Deadlock detection
- User-defined number of processes and resources
- Dynamic input of maximum, allocation, and available resources
- Visual representation of resource allocation and safe sequence (if applicable)


## 🧪 How It Works

1. User enters:
   - Number of processes and resources
   - Allocation matrix
   - Maximum matrix
   - Available resources
2. The algorithm checks whether the system is in a safe state.
3. If safe, the safe sequence is returned.
4. If not, a potential deadlock is reported.

## Tools & Technologies
•Language: C#
•Platform: .NET Framework
•IDE: Microsoft Visual Studio 2022
•Framework Type: Windows Forms Application
•OS Compatibility: Windows OS (Windows 10 or above)

## Screenshots
![image](https://github.com/user-attachments/assets/dea33288-61d1-4434-93e8-f42119288f89)

• Safe Sequence

![image](https://github.com/user-attachments/assets/860b69d0-50c4-4308-9e23-f2985034ec8a)

• Unsafe Sequence

![image](https://github.com/user-attachments/assets/bf18af18-c584-4e59-a911-587a1779529a)

## 📄 License
This project is licensed under the MIT License.
