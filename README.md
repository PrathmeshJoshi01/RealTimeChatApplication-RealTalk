# RealTimeChatApplication-RealTalk
# RealTalk - Real-time Chat Application

## 📌 Project Overview
RealTalk is a **real-time messaging application** built using **ASP.NET Core, SignalR, SQL Server, and WebSockets**. It enables **instant messaging**, **chat rooms**, and **real-time communication** with a smooth and responsive user interface. The system ensures **fast, low-latency messaging**, **chat history storage**, and a seamless user experience.

---

## 🚀 Tech Stack

### **Backend:**
- **ASP.NET Core** – Server-side framework
- **SignalR** – Real-time communication
- **SQL Server** – Chat history storage
- **Entity Framework Core** – ORM for database interactions
- **WebSockets** – Enables real-time message transfer

### **Frontend:**
- **React.js** – Dynamic UI
- **TailwindCSS** – Modern styling
- **Redux Toolkit** – State management
- **Axios** – API communication

### **Tools & Libraries:**
- **Postman** – API testing
- **Git & GitHub** – Version control
- **Visual Studio & VS Code** – Development

---

## 🛠️ Installation & Setup

### **1. Clone the Repository**
```sh
git clone https://github.com/yourusername/realtalk.git
cd realtalk
```

### **2. Backend Setup** (ASP.NET Core API)
1. Open the `RealTalk-Backend` folder in **Visual Studio**.
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Update database using Entity Framework:
   ```sh
   dotnet ef database update
   ```
4. Run the backend server:
   ```sh
   dotnet run
   ```

### **3. Frontend Setup** (React.js)
1. Open the `RealTalk-Frontend` folder in **VS Code**.
2. Install dependencies:
   ```sh
   npm install
   ```
3. Start the React development server:
   ```sh
   npm run dev
   ```

### **4. Configure SignalR in Frontend**
Modify `src/config.js` to connect to your API:
```js
const API_BASE_URL = "http://localhost:5000/chatHub";
export default API_BASE_URL;
```

### **5. Running the Application**
- Open **http://localhost:3000** for the frontend.
- The backend runs on **http://localhost:5000**.
- Test real-time messaging using multiple users.

---

## 📌 Features
✅ **Real-time messaging with SignalR**  
✅ **Chat rooms & private messaging**  
✅ **User authentication & profile management**  
✅ **Chat history stored in SQL Server**  
✅ **Responsive UI with TailwindCSS**  

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

🚀 **Built with passion for seamless communication!**

