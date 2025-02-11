# RealTimeChatApplication - RealTalk

## 📌 Project Overview
RealTalk is a **real-time chat application** built using **ASP.NET Core MVC and SignalR**. It allows users to communicate in real-time with instant messaging. A newly added feature enables **sending messages to specific users** directly within the browser, enhancing the user experience. The system ensures **low-latency, high-speed message delivery** without storing chat history, making it lightweight and efficient.

---

## 🚀 Tech Stack

### **Backend:**
- **ASP.NET Core MVC** – Web framework for building dynamic applications
- **SignalR** – Real-time communication
- **WebSockets** – Enables instant message transfer

### **Frontend:**
- **Razor Views (MVC)** – Server-side rendered UI
- **Bootstrap & CSS** – Responsive styling
- **JavaScript & jQuery** – UI interactions

### **Tools & Libraries:**
- **Postman** – API testing
- **Git & GitHub** – Version control
- **Visual Studio** – Development

---

## 🛠️ Installation & Setup

### **1. Clone the Repository**
```sh
git clone https://github.com/yourusername/realtalk.git
cd realtalk
```

### **2. Backend Setup** (ASP.NET Core MVC)
1. Open the project in **Visual Studio**.
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Run the backend server:
   ```sh
   dotnet run
   ```

### **3. Configure SignalR in Frontend**
Modify `wwwroot/js/chat.js` to connect to your SignalR Hub:
```js
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();

connection.start().catch(err => console.error(err.toString()));
```

### **4. Running the Application**
- Open **http://localhost:5000** in the browser.
- Open multiple browser tabs to test real-time messaging.

---

## 📌 Features
✅ **Real-time messaging with SignalR**  
✅ **Send messages to specific users**  
✅ **Lightweight – No chat history stored**  
✅ **User-friendly interface with Bootstrap**  
✅ **Efficient WebSocket-based communication**  

---

## 📄 License
This project is licensed under the **MIT License**.

---

## 💡 Contributing
1. **Fork** the repository.
2. **Create a feature branch** (`git checkout -b feature-xyz`).
3. **Commit your changes** (`git commit -m "Added new feature"`).
4. **Push to GitHub** (`git push origin feature-xyz`).
5. **Submit a Pull Request**.

---

## 📞 Contact
For any queries, feel free to reach out:  
📧 Email: **joshiprathmesh39@gmail.com**  
🔗 GitHub: **https://github.com/PrathmeshJoshi01**  

---

🚀 **Built for seamless and efficient real-time communication!**

