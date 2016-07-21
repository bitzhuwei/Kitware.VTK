using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageReader2Factory : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2Factory";

		public new static readonly string MRClassNameKey;

		static vtkImageReader2Factory()
		{
			vtkImageReader2Factory.MRClassNameKey = "class vtkImageReader2Factory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2Factory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2Factory"));
		}

		public vtkImageReader2Factory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Factory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2Factory New()
		{
			vtkImageReader2Factory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageReader2Factory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageReader2Factory.vtkImageReader2Factory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Factory_CreateImageReader2_01(string path, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkImageReader2 CreateImageReader2(string path)
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_CreateImageReader2_01(path, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2Factory_GetRegisteredReaders_02(HandleRef arg0);

		public static void GetRegisteredReaders(vtkImageReader2Collection arg0)
		{
			vtkImageReader2Factory.vtkImageReader2Factory_GetRegisteredReaders_02((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2Factory_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2Factory_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Factory_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageReader2Factory NewInstance()
		{
			vtkImageReader2Factory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2Factory_RegisterReader_07(HandleRef r);

		public static void RegisterReader(vtkImageReader2 r)
		{
			vtkImageReader2Factory.vtkImageReader2Factory_RegisterReader_07((r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Factory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2Factory SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2Factory vtkImageReader2Factory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader2Factory = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader2Factory.Register(null);
				}
			}
			return vtkImageReader2Factory;
		}
	}
}
