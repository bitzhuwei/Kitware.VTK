using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextMapper : vtkMapper2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextMapper";

		public new static readonly string MRClassNameKey;

		static vtkTextMapper()
		{
			vtkTextMapper.MRClassNameKey = "class vtkTextMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextMapper"));
		}

		public vtkTextMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextMapper New()
		{
			vtkTextMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextMapper.vtkTextMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_GetHeight_01(HandleRef pThis, HandleRef v);

		public virtual int GetHeight(vtkViewport v)
		{
			return vtkTextMapper.vtkTextMapper_GetHeight_01(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextMapper_GetInput_02(HandleRef pThis);

		public virtual string GetInput()
		{
			return Marshal.PtrToStringAnsi(vtkTextMapper.vtkTextMapper_GetInput_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_GetNumberOfLines_03(HandleRef pThis, string input);

		public int GetNumberOfLines(string input)
		{
			return vtkTextMapper.vtkTextMapper_GetNumberOfLines_03(base.GetCppThis(), input);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_GetNumberOfLines_04(HandleRef pThis);

		public virtual int GetNumberOfLines()
		{
			return vtkTextMapper.vtkTextMapper_GetNumberOfLines_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextMapper_GetSize_05(HandleRef pThis, HandleRef arg0, IntPtr size);

		public virtual void GetSize(vtkViewport arg0, IntPtr size)
		{
			vtkTextMapper.vtkTextMapper_GetSize_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_GetSystemFontSize_06(HandleRef pThis, int size);

		public virtual int GetSystemFontSize(int size)
		{
			return vtkTextMapper.vtkTextMapper_GetSystemFontSize_06(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextMapper_GetTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_GetTextProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_GetWidth_08(HandleRef pThis, HandleRef v);

		public virtual int GetWidth(vtkViewport v)
		{
			return vtkTextMapper.vtkTextMapper_GetWidth_08(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextMapper.vtkTextMapper_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextMapper.vtkTextMapper_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextMapper NewInstance()
		{
			vtkTextMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextMapper_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextMapper SafeDownCast(vtkObjectBase o)
		{
			vtkTextMapper vtkTextMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextMapper.vtkTextMapper_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextMapper = (vtkTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextMapper.Register(null);
				}
			}
			return vtkTextMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_SetConstrainedFontSize_14(HandleRef pThis, HandleRef arg0, int targetWidth, int targetHeight);

		public virtual int SetConstrainedFontSize(vtkViewport arg0, int targetWidth, int targetHeight)
		{
			return vtkTextMapper.vtkTextMapper_SetConstrainedFontSize_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), targetWidth, targetHeight);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_SetConstrainedFontSize_15(HandleRef arg0, HandleRef arg1, int targetWidth, int targetHeight);

		public static int SetConstrainedFontSize(vtkTextMapper arg0, vtkViewport arg1, int targetWidth, int targetHeight)
		{
			return vtkTextMapper.vtkTextMapper_SetConstrainedFontSize_15((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), targetWidth, targetHeight);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextMapper_SetInput_16(HandleRef pThis, string inputString);

		public virtual void SetInput(string inputString)
		{
			vtkTextMapper.vtkTextMapper_SetInput_16(base.GetCppThis(), inputString);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextMapper_SetRelativeFontSize_17(HandleRef arg0, HandleRef arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor);

		public static int SetRelativeFontSize(vtkTextMapper arg0, vtkViewport arg1, IntPtr winSize, IntPtr stringSize, float sizeFactor)
		{
			return vtkTextMapper.vtkTextMapper_SetRelativeFontSize_17((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), winSize, stringSize, sizeFactor);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextMapper_SetTextProperty_18(HandleRef pThis, HandleRef p);

		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextMapper.vtkTextMapper_SetTextProperty_18(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextMapper_ShallowCopy_19(HandleRef pThis, HandleRef tm);

		public void ShallowCopy(vtkTextMapper tm)
		{
			vtkTextMapper.vtkTextMapper_ShallowCopy_19(base.GetCppThis(), (tm == null) ? default(HandleRef) : tm.GetCppThis());
		}
	}
}
