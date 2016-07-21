using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkTextCodec : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextCodec";

		public new static readonly string MRClassNameKey;

		static vtkTextCodec()
		{
			vtkTextCodec.MRClassNameKey = "class vtkTextCodec";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextCodec"));
		}

		public vtkTextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTextCodec_CanHandle_01(HandleRef pThis, string NameString);

		public virtual bool CanHandle(string NameString)
		{
			return vtkTextCodec.vtkTextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTextCodec_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextCodec.vtkTextCodec_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTextCodec_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextCodec.vtkTextCodec_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodec_Name_04(HandleRef pThis);

		public virtual string Name()
		{
			return Marshal.PtrToStringAnsi(vtkTextCodec.vtkTextCodec_Name_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodec_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextCodec NewInstance()
		{
			vtkTextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodec.vtkTextCodec_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodec_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkTextCodec vtkTextCodec = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodec.vtkTextCodec_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodec = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodec.Register(null);
				}
			}
			return vtkTextCodec;
		}
	}
}
