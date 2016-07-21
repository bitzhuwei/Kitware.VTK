using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedWidthTextReader : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedWidthTextReader";

		public new static readonly string MRClassNameKey;

		static vtkFixedWidthTextReader()
		{
			vtkFixedWidthTextReader.MRClassNameKey = "class vtkFixedWidthTextReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedWidthTextReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedWidthTextReader"));
		}

		public vtkFixedWidthTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedWidthTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedWidthTextReader New()
		{
			vtkFixedWidthTextReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedWidthTextReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedWidthTextReader.vtkFixedWidthTextReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkFixedWidthTextReader_GetFieldWidth_01(HandleRef pThis);

		public virtual int GetFieldWidth()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetFieldWidth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedWidthTextReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkFixedWidthTextReader_GetHaveHeaders_03(HandleRef pThis);

		public virtual bool GetHaveHeaders()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetHaveHeaders_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkFixedWidthTextReader_GetStripWhiteSpace_04(HandleRef pThis);

		public virtual bool GetStripWhiteSpace()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetStripWhiteSpace_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_HaveHeadersOff_05(HandleRef pThis);

		public virtual void HaveHeadersOff()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_HaveHeadersOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_HaveHeadersOn_06(HandleRef pThis);

		public virtual void HaveHeadersOn()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_HaveHeadersOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkFixedWidthTextReader_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkFixedWidthTextReader_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedWidthTextReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedWidthTextReader NewInstance()
		{
			vtkFixedWidthTextReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedWidthTextReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedWidthTextReader SafeDownCast(vtkObjectBase o)
		{
			vtkFixedWidthTextReader vtkFixedWidthTextReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedWidthTextReader = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedWidthTextReader.Register(null);
				}
			}
			return vtkFixedWidthTextReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_SetFieldWidth_12(HandleRef pThis, int _arg);

		public virtual void SetFieldWidth(int _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetFieldWidth_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_SetFileName_13(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetFileName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_SetHaveHeaders_14(HandleRef pThis, byte _arg);

		public virtual void SetHaveHeaders(bool _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetHaveHeaders_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_SetStripWhiteSpace_15(HandleRef pThis, byte _arg);

		public virtual void SetStripWhiteSpace(bool _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetStripWhiteSpace_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOff_16(HandleRef pThis);

		public virtual void StripWhiteSpaceOff()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_StripWhiteSpaceOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOn_17(HandleRef pThis);

		public virtual void StripWhiteSpaceOn()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_StripWhiteSpaceOn_17(base.GetCppThis());
		}
	}
}
