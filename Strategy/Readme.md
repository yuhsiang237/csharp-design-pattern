# Strategy 策略模式
可以用來抽出核心演算法，利用委派的方式。

### 好處
1. 程式碼量減少(Code Space)
2. 可針對同一介面，重複使用Runner進行委派
3. 結構較好
4. 符合DIP
5. 允許「每個具體實作」可以被「多個不同的通用演算法」操控

### 壞處
1. 程式碼量
2. 相對於Template Method涉及更多層次。
3. 執行時間、資料儲存空間可能多一些


