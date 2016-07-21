using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLUtilities : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUtilities";

		public new static readonly string MRClassNameKey;

		static vtkXMLUtilities()
		{
			vtkXMLUtilities.MRClassNameKey = "class vtkXMLUtilities";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUtilities"));
		}

		public vtkXMLUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLUtilities New()
		{
			vtkXMLUtilities result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLUtilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLUtilities.vtkXMLUtilities_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUtilities_FactorElements_01(HandleRef tree);

		public static void FactorElements(vtkXMLDataElement tree)
		{
			vtkXMLUtilities.vtkXMLUtilities_FactorElements_01((tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUtilities_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUtilities_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUtilities_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLUtilities NewInstance()
		{
			vtkXMLUtilities result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUtilities_ReadElementFromFile_06(string filename, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkXMLDataElement ReadElementFromFile(string filename, int encoding)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_ReadElementFromFile_06(filename, encoding, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUtilities_ReadElementFromString_07(string str, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkXMLDataElement ReadElementFromString(string str, int encoding)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_ReadElementFromString_07(str, encoding, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUtilities_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUtilities vtkXMLUtilities = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUtilities = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUtilities.Register(null);
				}
			}
			return vtkXMLUtilities;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUtilities_UnFactorElements_09(HandleRef tree);

		public static void UnFactorElements(vtkXMLDataElement tree)
		{
			vtkXMLUtilities.vtkXMLUtilities_UnFactorElements_09((tree == null) ? default(HandleRef) : tree.GetCppThis());
		}
	}
}
