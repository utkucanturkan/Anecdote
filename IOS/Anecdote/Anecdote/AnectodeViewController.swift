//
//  AnectodeViewController.swift
//  Anecdote
//
//  Created by utkucanturkan on 16/03/2018.
//  Copyright © 2018 utkucanturkan. All rights reserved.
//

import UIKit

class AnectodeViewController: UIViewController {
    
    var anectode: Anectode? /*{
        didSet {
            updateUI()
            
           do {
                anectode = try Anectode.getAnectodeBy(title: anectodeTitle!)
                //anectode = try? Anectode.getAnectodeBy(title: anectodeTitle!)
            } catch AnectodeError.nomatchingitem(let msg) {
                isThereAnyError = (true, msg)
            } catch {
                isThereAnyError = (true, "Unexpected Error!")
            }
        }
    }*/
        
    
    @IBOutlet weak var lbltitle: UILabel!
    @IBOutlet weak var lbldescription: UITextView!
    
    private func updateUI() {
        lbltitle?.text = anectode?.title
        lbldescription?.text = anectode?.description
    }

    override func viewDidLoad() {
        super.viewDidLoad()
        updateUI()
    }
    
    private func showAlert(with message: String) {
        let alert = UIAlertController(title: "Warning", message: message, preferredStyle: .alert)
        alert.addAction(UIAlertAction(title: "Oh no!", style: .default, handler: nil))
        present(alert, animated: true, completion: nil)
    }

}
