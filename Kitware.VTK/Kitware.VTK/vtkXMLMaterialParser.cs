using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLMaterialParser : vtkXMLParser
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMaterialParser";

		public new static readonly string MRClassNameKey;

		static vtkXMLMaterialParser()
		{
			vtkXMLMaterialParser.MRClassNameKey = "class vtkXMLMaterialParser";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMaterialParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMaterialParser"));
		}

		public vtkXMLMaterialParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterialParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMaterialParser New()
		{
			vtkXMLMaterialParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterialParser.vtkXMLMaterialParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMaterialParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLMaterialParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLMaterialParser.vtkXMLMaterialParser_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterialParser_GetMaterial_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLMaterial GetMaterial()
		{
			vtkXMLMaterial vtkXMLMaterial = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterialParser.vtkXMLMaterialParser_GetMaterial_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMaterial = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMaterial.Register(null);
				}
			}
			return vtkXMLMaterial;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_InitializeParser_02(HandleRef pThis);

		public override int InitializeParser()
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_InitializeParser_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterialParser_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLMaterialParser NewInstance()
		{
			vtkXMLMaterialParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterialParser.vtkXMLMaterialParser_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMaterialParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_Parse_07(HandleRef pThis);

		public override int Parse()
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_Parse_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_Parse_08(HandleRef pThis, string inputString);

		public override int Parse(string inputString)
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_Parse_08(base.GetCppThis(), inputString);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterialParser_Parse_09(HandleRef pThis, string inputString, uint length);

		public override int Parse(string inputString, uint length)
		{
			return vtkXMLMaterialParser.vtkXMLMaterialParser_Parse_09(base.GetCppThis(), inputString, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterialParser_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMaterialParser SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMaterialParser vtkXMLMaterialParser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterialParser.vtkXMLMaterialParser_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMaterialParser = (vtkXMLMaterialParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMaterialParser.Register(null);
				}
			}
			return vtkXMLMaterialParser;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLMaterialParser_SetMaterial_11(HandleRef pThis, HandleRef arg0);

		public void SetMaterial(vtkXMLMaterial arg0)
		{
			vtkXMLMaterialParser.vtkXMLMaterialParser_SetMaterial_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
