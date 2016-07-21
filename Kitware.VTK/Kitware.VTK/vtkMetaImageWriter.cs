using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMetaImageWriter : vtkImageWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageWriter";

		public new static readonly string MRClassNameKey;

		static vtkMetaImageWriter()
		{
			vtkMetaImageWriter.MRClassNameKey = "class vtkMetaImageWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMetaImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageWriter"));
		}

		public vtkMetaImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMetaImageWriter New()
		{
			vtkMetaImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMetaImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMetaImageWriter.vtkMetaImageWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkMetaImageWriter_GetCompression_01(HandleRef pThis);

		public virtual bool GetCompression()
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_GetCompression_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageWriter_GetFileName_02(HandleRef pThis);

		public override string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageWriter.vtkMetaImageWriter_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageWriter_GetRAWFileName_03(HandleRef pThis);

		public virtual string GetRAWFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageWriter.vtkMetaImageWriter_GetRAWFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMetaImageWriter NewInstance()
		{
			vtkMetaImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMetaImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMetaImageWriter vtkMetaImageWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMetaImageWriter = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMetaImageWriter.Register(null);
				}
			}
			return vtkMetaImageWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMetaImageWriter_SetCompression_09(HandleRef pThis, byte compress);

		public virtual void SetCompression(bool compress)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetCompression_09(base.GetCppThis(), compress ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMetaImageWriter_SetFileName_10(HandleRef pThis, string fname);

		public override void SetFileName(string fname)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetFileName_10(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMetaImageWriter_SetRAWFileName_11(HandleRef pThis, string fname);

		public virtual void SetRAWFileName(string fname)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetRAWFileName_11(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMetaImageWriter_Write_12(HandleRef pThis);

		public override void Write()
		{
			vtkMetaImageWriter.vtkMetaImageWriter_Write_12(base.GetCppThis());
		}
	}
}
