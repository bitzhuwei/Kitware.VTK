using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInputStream : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInputStream";

		public new static readonly string MRClassNameKey;

		static vtkInputStream()
		{
			vtkInputStream.MRClassNameKey = "class vtkInputStream";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInputStream"));
		}

		public vtkInputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkInputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInputStream New()
		{
			vtkInputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInputStream.vtkInputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInputStream.vtkInputStream_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkInputStream_EndReading_01(HandleRef pThis);

		public virtual void EndReading()
		{
			vtkInputStream.vtkInputStream_EndReading_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkInputStream_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInputStream.vtkInputStream_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkInputStream_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInputStream.vtkInputStream_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkInputStream_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInputStream NewInstance()
		{
			vtkInputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInputStream.vtkInputStream_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkInputStream_Read_06(HandleRef pThis, IntPtr data, uint length);

		public virtual uint Read(IntPtr data, uint length)
		{
			return vtkInputStream.vtkInputStream_Read_06(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkInputStream_Read_07(HandleRef pThis, string data, uint length);

		public uint Read(string data, uint length)
		{
			return vtkInputStream.vtkInputStream_Read_07(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkInputStream_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInputStream SafeDownCast(vtkObjectBase o)
		{
			vtkInputStream vtkInputStream = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInputStream.vtkInputStream_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInputStream = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInputStream.Register(null);
				}
			}
			return vtkInputStream;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkInputStream_Seek_09(HandleRef pThis, uint offset);

		public virtual int Seek(uint offset)
		{
			return vtkInputStream.vtkInputStream_Seek_09(base.GetCppThis(), offset);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkInputStream_StartReading_10(HandleRef pThis);

		public virtual void StartReading()
		{
			vtkInputStream.vtkInputStream_StartReading_10(base.GetCppThis());
		}
	}
}
