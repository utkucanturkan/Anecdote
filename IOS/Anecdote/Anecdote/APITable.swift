//
//  APITable.swift
//  Anecdote
//
//  Created by utkucanturkan on 16/03/2018.
//  Copyright © 2018 utkucanturkan. All rights reserved.
//

import Foundation

struct APITable {
    var ok: Bool?
    var limit: Int?
    var offset: Int?
    var sort: String?
    var table: Table?
    
    private static let url: String = "https://apitable.skygeario.com/api/tables?id=74d9128d-e228-4800-9d30-8cc6cec720e4&token=5d19ca10-25e3-41cf-a524-2caab29b41da"
    
    init(data: [String:Any]) {
        self.ok = data["ok"] as? Bool
        self.limit = data["limit"] as? Int
        self.offset = data["offset"] as? Int
        self.sort = data["sort"] as? String
        
        if let table = data["table"] as? [String:Any] {
            self.table = Table(data: table)
        }
    }
    
    static func getDataFromServer(completion: @escaping (APITable) -> Void)  {
        let uri = URL(string: url)
        if let url = uri {
            let task = URLSession.shared.dataTask(with: url) { (data, urlresponse, error) in
                if data != nil {
                    if let json = try? JSONSerialization.jsonObject(with: data!, options: .allowFragments) as? [String:Any] {
                        DispatchQueue.main.async {
                            completion(APITable(data: json!))
                        }
                    }
                }
            }
            task.resume()
        }
    }
}


struct Table {
    var name: String?
    var recordCount: Int?
    var updateAt: String?
    var records = [Anectode]()
    
    init(data: [String:Any]) {
        self.name = data["name"] as? String
        self.recordCount = data["recordCount"] as? Int
        self.updateAt = data["updatedAt"] as? String
        
        for item in (data["records"] as? [Any])! {
            if let data = item as? [String:Any] {
                self.records.append(Anectode(data: data))
            }
        }
    }
}
