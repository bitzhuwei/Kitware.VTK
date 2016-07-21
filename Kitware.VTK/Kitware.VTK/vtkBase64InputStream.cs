using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBase64InputStream : vtkInputStream
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64InputStream";

		public new static readonly string MRClassNameKey;

		static vtkBase64InputStream()
		{
			vtkBase64InputStream.MRClassNameKey = "class vtkBase64InputStream";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64InputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64InputStream"));
		}

		public vtkBase64InputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64InputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64InputStream New()
		{
			vtkBase64InputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBase64InputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBase64InputStream.vtkBase64InputStream_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBase64InputStream_EndReading_01(HandleRef pThis);

		public override void EndReading()
		{
			vtkBase64InputStream.vtkBase64InputStream_EndReading_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64InputStream_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64InputStream_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64InputStream_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBase64InputStream NewInstance()
		{
			vtkBase64InputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkBase64InputStream_Read_06(HandleRef pThis, IntPtr data, uint length);

		public override uint Read(IntPtr data, uint length)
		{
			return vtkBase64InputStream.vtkBase64InputStream_Read_06(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64InputStream_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64InputStream SafeDownCast(vtkObjectBase o)
		{
			vtkBase64InputStream vtkBase64InputStream = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64InputStream = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64InputStream.Register(null);
				}
			}
			return vtkBase64InputStream;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64InputStream_Seek_08(HandleRef pThis, uint offset);

		public override int Seek(uint offset)
		{
			return vtkBase64InputStream.vtkBase64InputStream_Seek_08(base.GetCppThis(), offset);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBase64InputStream_StartReading_09(HandleRef pThis);

		public override void StartReading()
		{
			vtkBase64InputStream.vtkBase64InputStream_StartReading_09(base.GetCppThis());
		}
	}
}
