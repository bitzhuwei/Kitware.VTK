using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUTF16TextCodec : vtkTextCodec
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUTF16TextCodec";

		public new static readonly string MRClassNameKey;

		static vtkUTF16TextCodec()
		{
			vtkUTF16TextCodec.MRClassNameKey = "class vtkUTF16TextCodec";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUTF16TextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUTF16TextCodec"));
		}

		public vtkUTF16TextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF16TextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUTF16TextCodec New()
		{
			vtkUTF16TextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUTF16TextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUTF16TextCodec.vtkUTF16TextCodec_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkUTF16TextCodec_CanHandle_01(HandleRef pThis, string NameString);

		public override bool CanHandle(string NameString)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUTF16TextCodec_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUTF16TextCodec_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF16TextCodec_Name_04(HandleRef pThis);

		public override string Name()
		{
			return Marshal.PtrToStringAnsi(vtkUTF16TextCodec.vtkUTF16TextCodec_Name_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF16TextCodec_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUTF16TextCodec NewInstance()
		{
			vtkUTF16TextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF16TextCodec_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUTF16TextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkUTF16TextCodec vtkUTF16TextCodec = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUTF16TextCodec = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUTF16TextCodec.Register(null);
				}
			}
			return vtkUTF16TextCodec;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkUTF16TextCodec_SetBigEndian_08(HandleRef pThis, byte arg0);

		public void SetBigEndian(bool arg0)
		{
			vtkUTF16TextCodec.vtkUTF16TextCodec_SetBigEndian_08(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}
	}
}
