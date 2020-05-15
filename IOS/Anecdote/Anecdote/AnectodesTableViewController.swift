//
//  AnectodesTableViewController.swift
//  Anecdote
//
//  Created by utkucanturkan on 16/03/2018.
//  Copyright © 2018 utkucanturkan. All rights reserved.
//

import UIKit

class AnectodesTableViewController: UITableViewController {
    
    var anectodes = [Anectode]() {
        didSet {
            self.tableView.reloadData()
        }
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        APITable.getDataFromServer { [unowned self] (result) in
            self.anectodes = (result.table?.records)!
        }
    }

 
    // MARK: - Table view data source

    override func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }

    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return anectodes.count
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: Constants.AnectodeTableViewCell, for: indexPath)
        cell.textLabel?.text = anectodes[indexPath.row].title
        return cell
    }
    
    // MARK: - Navigation

    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == Constants.AnectodeDetailSegue, let cell = sender as? UITableViewCell, let avc = segue.destination as? AnectodeViewController  {
            avc.anectode = anectodes.filter { $0.title == cell.textLabel?.text! }.first
        }
    }

}

struct Constants {
    static let AnectodeDetailSegue: String = "AnectodeDetailSegue"
    static let AnectodeTableViewCell: String = "AnectodeCell"
}
