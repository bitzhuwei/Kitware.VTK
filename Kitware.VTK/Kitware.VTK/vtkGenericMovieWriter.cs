using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericMovieWriter : vtkProcessObject
	{
		public enum MovieWriterErrorIds
		{
			CanNotCompress = 40003,
			CanNotFormat,
			ChangedResolutionError,
			InitError = 40001,
			NoInputError,
			UserError = 40000
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericMovieWriter";

		public new static readonly string MRClassNameKey;

		static vtkGenericMovieWriter()
		{
			vtkGenericMovieWriter.MRClassNameKey = "class vtkGenericMovieWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericMovieWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericMovieWriter"));
		}

		public vtkGenericMovieWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericMovieWriter_End_01(HandleRef pThis);

		public virtual void End()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_End_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericMovieWriter_GetError_02(HandleRef pThis);

		public virtual int GetError()
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_GetError_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericMovieWriter_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkGenericMovieWriter.vtkGenericMovieWriter_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericMovieWriter_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericMovieWriter.vtkGenericMovieWriter_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkGenericMovieWriter_GetStringFromErrorCode_05(uint arg0);

		public static string GetStringFromErrorCode(uint arg0)
		{
			return Marshal.PtrToStringAnsi(vtkGenericMovieWriter.vtkGenericMovieWriter_GetStringFromErrorCode_05(arg0));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericMovieWriter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericMovieWriter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericMovieWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericMovieWriter NewInstance()
		{
			vtkGenericMovieWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericMovieWriter.vtkGenericMovieWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericMovieWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericMovieWriter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericMovieWriter vtkGenericMovieWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericMovieWriter.vtkGenericMovieWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericMovieWriter = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericMovieWriter.Register(null);
				}
			}
			return vtkGenericMovieWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericMovieWriter_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericMovieWriter_SetInput_11(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkImageData input)
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_SetInput_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericMovieWriter_Start_12(HandleRef pThis);

		public virtual void Start()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_Start_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericMovieWriter_Write_13(HandleRef pThis);

		public virtual void Write()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_Write_13(base.GetCppThis());
		}
	}
}
