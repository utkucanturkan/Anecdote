//
//  Anectode.swift
//  Anecdote
//
//  Created by utkucanturkan on 16/03/2018.
//  Copyright © 2018 utkucanturkan. All rights reserved.
//

import Foundation

struct Anectode {
    
    var title: String?
    var description: String?
    
    init(data: [String: Any]?) {
        guard let dictionary = data else { print(ErrorMessages.noItem); return }
        title = dictionary["title"] as? String
        description = dictionary["description"] as? String
    }
    
}

enum AnectodeError: Error {
    case nomatchingitem(String)
}

private struct ErrorMessages {
    static let noItem: String = "No Item"
}
