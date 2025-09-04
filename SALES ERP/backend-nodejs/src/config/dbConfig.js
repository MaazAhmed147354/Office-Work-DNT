const { Sequelize } = require("sequelize");
require("dotenv").config();

const sequelize = new Sequelize(
  process.env.DB_NAME,
  process.env.DB_USER,
  process.env.DB_PASSWORD,
  {
    host: process.env.DB_HOST,
    port: process.env.DB_PORT,
    dialect: process.env.DB_DIALECT || "mssql",
    dialectOptions: {
      options: {
        encrypt: false, // Set to true if using Azure or encrypted connection
        trustServerCertificate: true, // Required for most local/non-verified certs
      },
    },
    pool: {
      max: 10,
      min: 0,
      acquire: 30000,
      idle: 10000,
    },
    logging: false, // Optional: disable SQL logs
  }
);

// Test connection
(async () => {
  try {
    await sequelize.authenticate();
    console.log("✅ Sequelize: Connected to SQL Server");
  } catch (error) {
    console.error("❌ Sequelize connection failed:", error.message);
  }
})();

module.exports = sequelize;
