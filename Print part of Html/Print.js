    function printContent(el) {
        var restorePage = document.body.innerHTML;
		
        var printContent = document.getElementById(el).innerHTML;
		
        document.body.innerHTML = printContent;
		
        window.print();
		
        document.body.innerHTML = restorePage;
		
    }
	