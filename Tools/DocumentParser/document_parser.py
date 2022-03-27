from lxml import etree
import xml.etree.ElementTree as elemTree

parser = etree.XMLParser(remove_blank_text=True)
tree = elemTree.parse('docs.xml', parser=parser)

root = tree.getroot()

for member_item in root.iter('member'):
    # member 요소의 attribute 출력
    print(member_item.attrib)

    for summary_item in member_item.findall('summary'):
        #print(summary_item.text)
        for line in summary_item.text.splitlines():
            print(line.strip())

    for param_item in member_item.findall('param'):
        for param_attribute_item in param_item.attrib:
            print('name : ', param_attribute_item, 'type :', param_item.attrib[param_attribute_item])

    for code_item in member_item.findall('code'):
        print('\t [code]', code_item.text)
    