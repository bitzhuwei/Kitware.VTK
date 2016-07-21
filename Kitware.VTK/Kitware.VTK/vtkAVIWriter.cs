using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAVIWriter : vtkGenericMovieWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAVIWriter";

		public new static readonly string MRClassNameKey;

		static vtkAVIWriter()
		{
			vtkAVIWriter.MRClassNameKey = "class vtkAVIWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAVIWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVIWriter"));
		}

		public vtkAVIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAVIWriter New()
		{
			vtkAVIWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAVIWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAVIWriter.vtkAVIWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_End_01(HandleRef pThis);

		public override void End()
		{
			vtkAVIWriter.vtkAVIWriter_End_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVIWriter_GetCompressorFourCC_02(HandleRef pThis);

		public virtual string GetCompressorFourCC()
		{
			return Marshal.PtrToStringAnsi(vtkAVIWriter.vtkAVIWriter_GetCompressorFourCC_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetPromptCompressionOptions_03(HandleRef pThis);

		public virtual int GetPromptCompressionOptions()
		{
			return vtkAVIWriter.vtkAVIWriter_GetPromptCompressionOptions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetQuality_04(HandleRef pThis);

		public virtual int GetQuality()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQuality_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetQualityMaxValue_05(HandleRef pThis);

		public virtual int GetQualityMaxValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQualityMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetQualityMinValue_06(HandleRef pThis);

		public virtual int GetQualityMinValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQualityMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetRate_07(HandleRef pThis);

		public virtual int GetRate()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRate_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetRateMaxValue_08(HandleRef pThis);

		public virtual int GetRateMaxValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRateMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_GetRateMinValue_09(HandleRef pThis);

		public virtual int GetRateMinValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRateMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVIWriter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVIWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAVIWriter NewInstance()
		{
			vtkAVIWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_PromptCompressionOptionsOff_14(HandleRef pThis);

		public virtual void PromptCompressionOptionsOff()
		{
			vtkAVIWriter.vtkAVIWriter_PromptCompressionOptionsOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_PromptCompressionOptionsOn_15(HandleRef pThis);

		public virtual void PromptCompressionOptionsOn()
		{
			vtkAVIWriter.vtkAVIWriter_PromptCompressionOptionsOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVIWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAVIWriter SafeDownCast(vtkObjectBase o)
		{
			vtkAVIWriter vtkAVIWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAVIWriter = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAVIWriter.Register(null);
				}
			}
			return vtkAVIWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_SetCompressorFourCC_17(HandleRef pThis, string _arg);

		public virtual void SetCompressorFourCC(string _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetCompressorFourCC_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_SetPromptCompressionOptions_18(HandleRef pThis, int _arg);

		public virtual void SetPromptCompressionOptions(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetPromptCompressionOptions_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_SetQuality_19(HandleRef pThis, int _arg);

		public virtual void SetQuality(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetQuality_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_SetRate_20(HandleRef pThis, int _arg);

		public virtual void SetRate(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetRate_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_Start_21(HandleRef pThis);

		public override void Start()
		{
			vtkAVIWriter.vtkAVIWriter_Start_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVIWriter_Write_22(HandleRef pThis);

		public override void Write()
		{
			vtkAVIWriter.vtkAVIWriter_Write_22(base.GetCppThis());
		}
	}
}
