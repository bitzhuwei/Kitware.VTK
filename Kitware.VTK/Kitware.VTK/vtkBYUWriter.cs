using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBYUWriter : vtkPolyDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBYUWriter";

		public new static readonly string MRClassNameKey;

		static vtkBYUWriter()
		{
			vtkBYUWriter.MRClassNameKey = "class vtkBYUWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBYUWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUWriter"));
		}

		public vtkBYUWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBYUWriter New()
		{
			vtkBYUWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBYUWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBYUWriter.vtkBYUWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_GetDisplacementFileName_01(HandleRef pThis);

		public virtual string GetDisplacementFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetDisplacementFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_GetGeometryFileName_02(HandleRef pThis);

		public virtual string GetGeometryFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetGeometryFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_GetScalarFileName_03(HandleRef pThis);

		public virtual string GetScalarFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetScalarFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_GetTextureFileName_04(HandleRef pThis);

		public virtual string GetTextureFileName()
		{
			return Marshal.PtrToStringAnsi(vtkBYUWriter.vtkBYUWriter_GetTextureFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUWriter_GetWriteDisplacement_05(HandleRef pThis);

		public virtual int GetWriteDisplacement()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteDisplacement_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUWriter_GetWriteScalar_06(HandleRef pThis);

		public virtual int GetWriteScalar()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteScalar_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUWriter_GetWriteTexture_07(HandleRef pThis);

		public virtual int GetWriteTexture()
		{
			return vtkBYUWriter.vtkBYUWriter_GetWriteTexture_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUWriter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBYUWriter_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBYUWriter.vtkBYUWriter_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBYUWriter NewInstance()
		{
			vtkBYUWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBYUWriter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBYUWriter SafeDownCast(vtkObjectBase o)
		{
			vtkBYUWriter vtkBYUWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBYUWriter.vtkBYUWriter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBYUWriter = (vtkBYUWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBYUWriter.Register(null);
				}
			}
			return vtkBYUWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetDisplacementFileName_13(HandleRef pThis, string _arg);

		public virtual void SetDisplacementFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetDisplacementFileName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetGeometryFileName_14(HandleRef pThis, string _arg);

		public virtual void SetGeometryFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetGeometryFileName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetScalarFileName_15(HandleRef pThis, string _arg);

		public virtual void SetScalarFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetScalarFileName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetTextureFileName_16(HandleRef pThis, string _arg);

		public virtual void SetTextureFileName(string _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetTextureFileName_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetWriteDisplacement_17(HandleRef pThis, int _arg);

		public virtual void SetWriteDisplacement(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteDisplacement_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetWriteScalar_18(HandleRef pThis, int _arg);

		public virtual void SetWriteScalar(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteScalar_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_SetWriteTexture_19(HandleRef pThis, int _arg);

		public virtual void SetWriteTexture(int _arg)
		{
			vtkBYUWriter.vtkBYUWriter_SetWriteTexture_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteDisplacementOff_20(HandleRef pThis);

		public virtual void WriteDisplacementOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteDisplacementOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteDisplacementOn_21(HandleRef pThis);

		public virtual void WriteDisplacementOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteDisplacementOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteScalarOff_22(HandleRef pThis);

		public virtual void WriteScalarOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteScalarOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteScalarOn_23(HandleRef pThis);

		public virtual void WriteScalarOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteScalarOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteTextureOff_24(HandleRef pThis);

		public virtual void WriteTextureOff()
		{
			vtkBYUWriter.vtkBYUWriter_WriteTextureOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBYUWriter_WriteTextureOn_25(HandleRef pThis);

		public virtual void WriteTextureOn()
		{
			vtkBYUWriter.vtkBYUWriter_WriteTextureOn_25(base.GetCppThis());
		}
	}
}
