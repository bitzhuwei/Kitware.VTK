using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSynchronizedTemplates2D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplates2D";

		public new static readonly string MRClassNameKey;

		static vtkSynchronizedTemplates2D()
		{
			vtkSynchronizedTemplates2D.MRClassNameKey = "class vtkSynchronizedTemplates2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplates2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplates2D"));
		}

		public vtkSynchronizedTemplates2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplates2D New()
		{
			vtkSynchronizedTemplates2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSynchronizedTemplates2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_ComputeScalarsOff_01(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_ComputeScalarsOn_02(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GenerateValues_03(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GenerateValues_04(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates2D_GetArrayComponent_05(HandleRef pThis);

		public virtual int GetArrayComponent()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetArrayComponent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates2D_GetComputeScalars_06(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetComputeScalars_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkSynchronizedTemplates2D_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates2D_GetNumberOfContours_08(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetNumberOfContours_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSynchronizedTemplates2D_GetValue_09(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValue_09(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates2D_GetValues_10(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValues_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_GetValues_11(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValues_11(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates2D_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates2D_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates2D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSynchronizedTemplates2D NewInstance()
		{
			vtkSynchronizedTemplates2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates2D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplates2D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplates2D vtkSynchronizedTemplates2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplates2D = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplates2D.Register(null);
				}
			}
			return vtkSynchronizedTemplates2D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_SetArrayComponent_17(HandleRef pThis, int _arg);

		public virtual void SetArrayComponent(int _arg)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetArrayComponent_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_SetComputeScalars_18(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetComputeScalars_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_SetNumberOfContours_19(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetNumberOfContours_19(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates2D_SetValue_20(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetValue_20(base.GetCppThis(), i, value);
		}
	}
}
