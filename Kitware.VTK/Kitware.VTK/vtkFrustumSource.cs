using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFrustumSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumSource";

		public new static readonly string MRClassNameKey;

		static vtkFrustumSource()
		{
			vtkFrustumSource.MRClassNameKey = "class vtkFrustumSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrustumSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumSource"));
		}

		public vtkFrustumSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrustumSource New()
		{
			vtkFrustumSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFrustumSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFrustumSource.vtkFrustumSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFrustumSource_GetLinesLength_01(HandleRef pThis);

		public virtual double GetLinesLength()
		{
			return vtkFrustumSource.vtkFrustumSource_GetLinesLength_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkFrustumSource_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkFrustumSource.vtkFrustumSource_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumSource_GetPlanes_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlanes GetPlanes()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_GetPlanes_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkFrustumSource_GetShowLines_04(HandleRef pThis);

		public virtual bool GetShowLines()
		{
			return vtkFrustumSource.vtkFrustumSource_GetShowLines_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFrustumSource_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFrustumSource_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFrustumSource.vtkFrustumSource_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFrustumSource NewInstance()
		{
			vtkFrustumSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrustumSource SafeDownCast(vtkObjectBase o)
		{
			vtkFrustumSource vtkFrustumSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumSource.vtkFrustumSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrustumSource = (vtkFrustumSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrustumSource.Register(null);
				}
			}
			return vtkFrustumSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFrustumSource_SetLinesLength_10(HandleRef pThis, double _arg);

		public virtual void SetLinesLength(double _arg)
		{
			vtkFrustumSource.vtkFrustumSource_SetLinesLength_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFrustumSource_SetPlanes_11(HandleRef pThis, HandleRef planes);

		public virtual void SetPlanes(vtkPlanes planes)
		{
			vtkFrustumSource.vtkFrustumSource_SetPlanes_11(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFrustumSource_SetShowLines_12(HandleRef pThis, byte _arg);

		public virtual void SetShowLines(bool _arg)
		{
			vtkFrustumSource.vtkFrustumSource_SetShowLines_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFrustumSource_ShowLinesOff_13(HandleRef pThis);

		public virtual void ShowLinesOff()
		{
			vtkFrustumSource.vtkFrustumSource_ShowLinesOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFrustumSource_ShowLinesOn_14(HandleRef pThis);

		public virtual void ShowLinesOn()
		{
			vtkFrustumSource.vtkFrustumSource_ShowLinesOn_14(base.GetCppThis());
		}
	}
}
