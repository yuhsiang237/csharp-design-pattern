# Factory 工廠模式
提供一個工廠介面，將產生實體的程式碼交由子類別各自實現。
### 好處
1. 可以將工廠內部的實作替換為另一種實作，就可以替換一系列相關的物件。
2. 可避免依賴於具體類別，特別是具體類別不穩定時。
3. 如果有需要用到PROXY模式建議採納
4. 容易變動的類別可使用工廠
### 壞處
1. 較具複雜性(建立一個新類別需要建立4個檔案，2個為類別及工廠類別介面，2個為代表實作這些介面的類別)



