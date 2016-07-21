using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageWriter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWriter";

		public new static readonly string MRClassNameKey;

		static vtkImageWriter()
		{
			vtkImageWriter.MRClassNameKey = "class vtkImageWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWriter"));
		}

		public vtkImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWriter New()
		{
			vtkImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageWriter.vtkImageWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_DeleteFiles_01(HandleRef pThis);

		public void DeleteFiles()
		{
			vtkImageWriter.vtkImageWriter_DeleteFiles_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageWriter_GetFileDimensionality_02(HandleRef pThis);

		public virtual int GetFileDimensionality()
		{
			return vtkImageWriter.vtkImageWriter_GetFileDimensionality_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_GetFilePattern_04(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFilePattern_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_GetFilePrefix_05(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFilePrefix_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageWriter_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageWriter.vtkImageWriter_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageWriter_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageWriter.vtkImageWriter_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageWriter NewInstance()
		{
			vtkImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkImageWriter vtkImageWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWriter = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWriter.Register(null);
				}
			}
			return vtkImageWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_SetFileDimensionality_12(HandleRef pThis, int _arg);

		public virtual void SetFileDimensionality(int _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFileDimensionality_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_SetFileName_13(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFileName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_SetFilePattern_14(HandleRef pThis, string _arg);

		public virtual void SetFilePattern(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFilePattern_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_SetFilePrefix_15(HandleRef pThis, string _arg);

		public virtual void SetFilePrefix(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFilePrefix_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageWriter_Write_16(HandleRef pThis);

		public virtual void Write()
		{
			vtkImageWriter.vtkImageWriter_Write_16(base.GetCppThis());
		}
	}
}
