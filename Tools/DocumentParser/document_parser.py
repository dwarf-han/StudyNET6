from lxml import etree
import xml.etree.ElementTree as elemTree

parser = etree.XMLParser(remove_blank_text=True)
tree = elemTree.parse('docs.xml', parser=parser)

root = tree.getroot()

for member_item in root.iter('member'):
    # print(member_item.attrib)

    for summary_item in member_item.findall('summary'):
        for line in summary_item.text.splitlines():
            print(line.strip())

    # for param_item in member_item.findall('param'):
    #     print('\t', param_item.attrib)

    # for code_item in member_item.findall('code'):
    #     print('\t [code]', code_item.text)
    