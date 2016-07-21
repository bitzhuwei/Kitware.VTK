using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLFileReadTester : vtkXMLParser
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLFileReadTester";

		public new static readonly string MRClassNameKey;

		static vtkXMLFileReadTester()
		{
			vtkXMLFileReadTester.MRClassNameKey = "class vtkXMLFileReadTester";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLFileReadTester.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLFileReadTester"));
		}

		public vtkXMLFileReadTester(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLFileReadTester New()
		{
			vtkXMLFileReadTester result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLFileReadTester() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLFileReadTester.vtkXMLFileReadTester_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_GetFileDataType_01(HandleRef pThis);

		public virtual string GetFileDataType()
		{
			return Marshal.PtrToStringAnsi(vtkXMLFileReadTester.vtkXMLFileReadTester_GetFileDataType_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_GetFileName_02(HandleRef pThis);

		public override string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLFileReadTester.vtkXMLFileReadTester_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_GetFileVersion_03(HandleRef pThis);

		public virtual string GetFileVersion()
		{
			return Marshal.PtrToStringAnsi(vtkXMLFileReadTester.vtkXMLFileReadTester_GetFileVersion_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLFileReadTester_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLFileReadTester_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLFileReadTester NewInstance()
		{
			vtkXMLFileReadTester result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLFileReadTester_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLFileReadTester SafeDownCast(vtkObjectBase o)
		{
			vtkXMLFileReadTester vtkXMLFileReadTester = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLFileReadTester = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLFileReadTester.Register(null);
				}
			}
			return vtkXMLFileReadTester;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLFileReadTester_SetFileName_09(HandleRef pThis, string _arg);

		public override void SetFileName(string _arg)
		{
			vtkXMLFileReadTester.vtkXMLFileReadTester_SetFileName_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLFileReadTester_TestReadFile_10(HandleRef pThis);

		public int TestReadFile()
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_TestReadFile_10(base.GetCppThis());
		}
	}
}
