// services/BaseService.js
class BaseService {
    async apiCall(method = "GET", controller = "User", endpoint = "AppUsers", view = "Grid%20view", payload = null, airtableWhere) {
      try {
        const token = localStorage.getItem("access_token");
        if (!token && endpoint !== "exchange") {
          return null;
        }
  
        airtableWhere = airtableWhere ? `&airtableWhere=${airtableWhere}` : '';
        view = view ? `&view=${view}` : '';
  
        var url = `https://localhost:42016/${controller}/${endpoint}?${view}${airtableWhere}`;
        if (method == "DELETE") {
          url = `https://localhost:42016/${controller}/${endpoint}?id=${payload}`;
        } 

        const response = await fetch(url, {
          method: method,
          headers: { "Content-Type": "application/json", Authorization: `Bearer ${token}` },
          body: payload ? JSON.stringify(payload) : null,
        });
  
        if (!response.ok) {
          throw new Error(`Failed to ${method} ${endpoint} ${JSON.stringify(response)}`);
        }
  
        return await response.json();
      } catch (ex) {
        console.error('Error: ', ex);
      }
    }
  }
  
  export default BaseService;
  
